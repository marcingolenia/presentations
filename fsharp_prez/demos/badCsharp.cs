public class SoCalledDomainService
    {
        private readonly INotifier _notifier;
        private readonly IMailService _mailService;
        private readonly IRepository _repository;
        private readonly ILogger _logger;

        public SoCalledDomainService(
            INotifier notifier,
            IMailService mailService,
            IRepository repository,
            ILogger logger)
        {
            _notifier = notifier;
            _mailService = mailService;
            _repository = repository;
            _logger = logger;
        }

        private void SomeDomain() {
            // some domain logic
        }

        public void ExecuteDomainLogic()
        {
            try
            {
                _logger.LogInfo("Executing domain logic...");

                SomeDomain();
                var data = _repository.GetData();
                if (data == null)
                {
                    _logger.LogWarning("No data found.");
                    _notifier.Notify("No data available.");
                    return;
                }

                _mailService.SendMail("recipient@example.com", "Subject", "Body content");
                _logger.LogInfo("Mail sent successfully.");
            }
            catch (Exception ex)
            {
                _logger.LogError("An error occurred while executing domain logic.", ex);
                _notifier.Notify("An error occurred. Please check the logs.");
            }
        }
    }