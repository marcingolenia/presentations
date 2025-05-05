import { render, screen, waitFor } from '@testing-library/react';
import userEvent from '@testing-library/user-event';
import { rest } from 'msw';
import { setupServer } from 'msw/node';
import BeneficjenciForm from './BeneficjenciForm';
import React from 'react';

const server = setupServer();

beforeAll(() => server.listen());
afterEach(() => server.resetHandlers());
afterAll(() => server.close());

test('modifies and displays updated organization beneficjenci', async () => {
  const testId = '1234';
  const initialData = {
    id: testId,
    LiczbaBeneficjentow: 50,
    Beneficjenci: 'original',
  };

  const updatedData = {
    LiczbaBeneficjentow: 70,
    Beneficjenci: 'updated-value',
  };

  // Initial GET handler
  server.use(
    rest.get(`/organizations/${testId}`, (req, res, ctx) => {
      return res(ctx.json(initialData));
    })
  );

  // PUT handler to capture form submission
  server.use(
    rest.put(`/organizations/${testId}/beneficjenci`, async (req, res, ctx) => {
      const body = await req.json();
      expect(body.LiczbaBeneficjentow).toBe(updatedData.LiczbaBeneficjentow.toString());
      expect(body.Beneficjenci).toBe(updatedData.Beneficjenci);
      return res(ctx.status(200), ctx.json(body));
    })
  );

  // Render the component
  render(<BeneficjenciForm organizationId={testId} />);

  // Wait for initial values to load
  await screen.findByDisplayValue(initialData.LiczbaBeneficjentow.toString());
  await screen.findByDisplayValue(initialData.Beneficjenci);

  // Fill in new values
  await userEvent.clear(screen.getByLabelText(/liczba beneficjentow/i));
  await userEvent.type(screen.getByLabelText(/liczba beneficjentow/i), updatedData.LiczbaBeneficjentow.toString());

  await userEvent.clear(screen.getByLabelText(/beneficjenci/i));
  await userEvent.type(screen.getByLabelText(/beneficjenci/i), updatedData.Beneficjenci);

  // Submit the form
  await userEvent.click(screen.getByRole('button', { name: /submit/i }));

  // Assert the UI shows updated values
  await waitFor(() => {
    expect(screen.getByText(updatedData.LiczbaBeneficjentow.toString())).toBeInTheDocument();
    expect(screen.getByText(updatedData.Beneficjenci)).toBeInTheDocument();
  });
});