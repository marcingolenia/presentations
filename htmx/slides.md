---
title: Webapps for tired engineers
class: text-center
drawings:
  persist: false
transition: slide-up
mdc: true
colorSchema: dark
---

# HTMX: Webapps for tired engineers


<div class="abs-br m-6 text-xl">
  <button @click="$slidev.nav.openInEditor" title="Open in Editor" class="slidev-icon-btn">
    <carbon:edit />
  </button>
</div>

<!--
The last comment block of each slide will be treated as slide notes. It will be visible and editable in Presenter Mode along with the slide. [Read more in the docs](https://sli.dev/guide/syntax.html#notes)
-->

---
transition: slide-up
layout: center
class: text-center

---

<div style="display:grid;grid-template-columns: repeat(3, 1fr); gap: 10px; grid-auto-rows: minmax(100px, auto);">
  <v-click><img src="/img/fe1.png" alt="🤗" width="180" height="180"></v-click>
  <v-click><img src="/img/netmvc.png" alt="🤗" width="180" height="180"></v-click>
  <v-click><img src="/img/fe2.webp" alt="🤗" width="180" height="180"></v-click>
  <v-click><img src="/img/fe3.png" alt="🤗" width="180" height="180"></v-click>
  <v-click><img src="/img/fe4.png" alt="🤗" width="180" height="180"></v-click>
  <v-click><img src="/img/fe6.jpg" alt="🤗" width="180" height="180"></v-click>
  <v-click><img src="/img/preact.webp" alt="🤗"  style="grid-column-end: 2;" width="180" height="180"></v-click>
  <v-click><img src="/img/fe5.webp" alt="🤗" style="grid-column-end: 3;" width="160" height="180"></v-click>
  <v-click><p style="font-size:150px;">?</p></v-click>
</div>
<!--That is a lot isn't it? 
- Webpack
- Rollup
- Vite
- Jest / Vitest
- Aurelia CLI / create-react-app
- Emotion for CSS in JS
- JSX / TSX
- Tanstack Query
- Awesome Ecma script modules versus CommonJS problems
- and a shitload of other other packages
-->

---
transition: blur
layout: center
class: text-center
---

<img src="/img/current_status.png" style="height:500px">  

---
transition: slide-up
layout: center
class: text-center

---

<img src="/img/webframeworks.jpeg">

---
transition: fade
layout: center
class: text-center

---

<div style="display:grid;grid-template-columns: repeat(3, 1fr); gap: 10px; grid-auto-rows: minmax(100px, auto);">
  <img src="/img/fe1.png" alt="🤗" width="180" height="180">
  <img src="/img/netmvc.png" alt="🤗" width="180" height="180">
  <img src="/img/fe2.webp" alt="🤗" width="180" height="180">
  <img src="/img/fe3.png" alt="🤗" width="180" height="180">
  <img src="/img/fe4.png" alt="🤗" width="180" height="180">
  <img src="/img/fe6.jpg" alt="🤗" width="180" height="180">
  <img src="/img/preact.webp" alt="🤗"  style="grid-column-end: 2;" width="180" height="180">
  <img src="/img/fe5.webp" alt="🤗" style="grid-column-end: 3;" width="160" height="180">
  <p style="font-size:150px;width:227px">?</p>
</div>

---
transition: fade
layout: center
class: text-center

---

<div style="display:grid;grid-template-columns: repeat(3, 1fr); gap: 10px; grid-auto-rows: minmax(100px, auto);">
  <img src="/img/fe1.png" alt="🤗" width="180" height="180">
  <img src="/img/netmvc.png" alt="🤗" width="180" height="180">
  <img src="/img/fe2.webp" alt="🤗" width="180" height="180">
  <img src="/img/fe3.png" alt="🤗" width="180" height="180">
  <img src="/img/fe4.png" alt="🤗" width="180" height="180">
  <img src="/img/fe6.jpg" alt="🤗" width="180" height="180">
  <img src="/img/preact.webp" alt="🤗"  style="grid-column-end: 2;" width="180" height="180">
  <img src="/img/fe5.webp" alt="🤗" style="grid-column-end: 3;" width="160" height="180">
  <span style="font-size:60px; display:flex; align-items:center"><<span color="blue">/</span>>htm<span color="blue">x</span></span>
</div>

---
transition: fade
layout: center
class: text-center

---

<div style="display:grid;grid-template-columns: repeat(2, 1fr); gap: 10px; grid-auto-rows: minmax(100px, auto);">
  <img src="/img/netmvc.png" alt="🤗" width="180" height="180">
  <span style="font-size:60px; display:flex; align-items:center"><<span color="blue">/</span>>htm<span color="blue">x</span></span>
</div>

---
transition: fade
layout: center
class: text-center
---

<div style="display:grid;grid-template-columns: repeat(3, 1fr); gap: 10px;">
  <div style="display: flex; flex-direction: column; gap: 10px;">
    <img src="/img/netmvc.png" alt="🤗" width="180" height="180">
    <img src="/img/springmvc.png" alt="🤗" width="180" height="180">
    <img src="/img/django.png" alt="🤗" width="180" height="180">
    <img src="/img/nest.png" alt="🤗" width="180" height="180">
  </div>
  <p style="font-size:60px; display:flex; align-items:center; justify-content:center; align-content:middle;">
  <picture>
    <source srcset="https://fonts.gstatic.com/s/e/notoemoji/latest/1f495/512.webp" type="image/webp">
    <img src="https://fonts.gstatic.com/s/e/notoemoji/latest/1f495/512.gif" alt="💕" width="182" height="182">
  </picture>
  </p>
  <span style="font-size:60px; display:flex; align-items:center"><<span color="blue">/</span>>htm<span color="blue">x</span></span>
</div>

---
transition: fade
layout: center
class: text-center
---

<div style="display:grid;grid-template-columns: repeat(3, 1fr); gap: 10px;">
  <div style="display: flex; flex-direction: column; gap: 10px;">
    <img src="/img/netmvc.png" alt="🤗" width="180" height="180">
    <img src="/img/springmvc.png" alt="🤗" width="180" height="180">
    <img src="/img/django.png" alt="🤗" width="180" height="180">
    <img src="/img/nest.png" alt="🤗" width="180" height="180">
  </div>
  <p style="font-size:60px; display:flex; align-items:center; justify-content:center; align-content:middle;">
  <picture style="position:relative;">
    <source srcset="https://fonts.gstatic.com/s/e/notoemoji/latest/1f495/512.webp" type="image/webp">
    <img src="https://fonts.gstatic.com/s/e/notoemoji/latest/1f495/512.gif" alt="💕" width="182" height="182">
    <p style="font-size: 120px; position: absolute; top: 50px; left: -75px; font-weight: bold; text-shadow: 5px 5px 10px blue; text-decoration: underline; transform: rotate(-25deg);">HOWL</p>
  </picture>
  </p>
  <span style="font-size:60px; display:flex; align-items:center"><<span color="blue">/</span>>htm<span color="blue">x</span></span>
</div>

---
transition: blur
layout: center
class: text-center
---

<img src="/img/hypertext.jpg" style="height:500px">
<!--
Forms, Buttons, Sliders, Maps, Images, Videos 
-->

---
transition: slide-up
---
`GET /accounts/12345`

<v-click>
```json
{
    "account": {
        "account_number": 12345,
        "balance": {
            "currency": "usd",
            "value": 100.00
        },
        "status": "good"
    }
}
```
</v-click>
<v-click>
```html
<html>
  <body>
    <div>Account number: 12345</div>
    <div>Balance: $100.00 USD</div>
    <div>Links:
        <a href="/accounts/12345/deposits">deposits</a>
        <a href="/accounts/12345/withdrawals">withdrawals</a>
        <a href="/accounts/12345/transfers">transfers</a>
        <a href="/accounts/12345/close-requests">close-requests</a>
    </div>
  <body>
</html>
```
</v-click>

---
transition: slide-up
---
`GET /accounts/12345`

<v-click>
```json
{
    "account": {
        "account_number": 12345,
        "balance": {
            "currency": "usd",
            "value": -50.00
        },
        "status": "overdrawn"
    }
}
```
</v-click>
<v-click>
```html
<html>
  <body>
    <div>Account number: 12345</div>
    <div>Balance: -$50.00 USD</div>
    <div>Links:
        <a href="/accounts/12345/deposits">deposits</a>
    </div>
  <body>
</html>
```
</v-click>

---
transition: fade
layout: center
class: text-center
---

<img src="/img/hateoas.png" style="height:500px">
```
https://stackoverflow.com/questions/25172600/rest-what-exactly-is-meant-by-uniform-interface
```
---
transition: fade
layout: center
class: text-center
---

<img src="/img/rest_so1.png" style="height:500px">

---
transition: fade
layout: center
class: text-center
---

<img src="/img/so_reply.png" style="height:500px">

---
transition: fade
layout: center
class: text-center
---

<img src="/img/rest1.png" style="height:500px">
<img src="/img/roy1.png" style="position:absolute; right:50px; width:320px;bottom:200px;">
<img src="/img/roy2.png" style="position:absolute; right:50px; width:320px;bottom:160px;">
<img src="/img/roy3.png" style="position:absolute; right:50px; width:320px;bottom:120px;">

---
transition: fade
layout: center
class: text-center
---

<img src="/img/ssr_react_htmx1.png" style="width:800px">

---
transition: fade
layout: center
class: text-center
---

<img src="/img/ssr_react_htmx2.png" style="width:800px">

---
transition: slide-up
layout: center
class: text-center
---

<img src="/img/ssr_react_htmx3.png" style="width:800px">

---
transition: blur
layout: center
---

# How?
<v-click><li>Why should only &lt;a&gt; and &lt;form&gt; be able to make HTTP requests?</li></v-click>
<v-click><li>Why should only click & submit events trigger them?</li></v-click>
<v-click><li>Why should only GET & POST methods be available?</li></v-click>
<v-click><li>Why should you only be able to replace the entire screen?</li></v-click>
<v-click><br/><br/>By removing these constraints, htmx completes HTML as a hypertext</v-click>

<!--Mention about vision, Triptych, hxTarget, hxSwap, hxGet, hxPushUrl, hxSwapOob, hx-trigger="keyup changed delay:1s"-->

---
transition: slide-up
layout: center
---

# HTMX example 1: validation
```html
<p>
  <label for="email">Email</label>
  <input name="email" id="email" type="email"
    hx-get="/contacts/{{contact.id}}/email"
    hx-target="next .error"
    hx-trigger="change, keyup delay:200ms changed"
    placeholder="Email" value="{{contact.email}}">
  <span class="error">{{contact.errors['email']}}</span>
</p>
```

---
transition: slide-up
layout: center
---

# HTMX example 2: Edit
```html
<form>
    <article class="focus-dim">
        <header class="action-header">
            <span>Beneficjenci</span>
            <div class="action-header-actions">
                <button hx-get="/organizations/105/beneficjenci" hx-target="closest article" hx-swap="outerHTML">
                    // icon svg boilerplate
                <button hx-put="/organizations/105/beneficjenci" hx-target="closest article" hx-swap="outerHTML">
                    // icon svg boilerplate
            </div>
        </header>
        <p>
            <label><b>Liczba Beneficjent&#243;w</b></label>
            <input value="180" name="LiczbaBeneficjentow">
        </p>
        <p>
            <label><b>Beneficjenci</b></label>
            <input value="Osoby starsze, samotne" name="Beneficjenci">
        </p>
    </article>
</form>
```
<img src="/img/beneficjenci.png" style="width:375px; position: absolute; bottom: 10px; right:10px;">

---
transition: none
layout: center
---

# HTMX example 3: Implementation details (1/2)
```fsharp
// ListTemplate.fs
module Organizations.ListTemplate

open Organizations.Application.ReadModels

let Template (data: OrganizationSummary list) =
    tbody () {
        for row in data do
            tr (style = "position: relative") {
                td () {
                    a (href = $"/organizations/%i{row.Teczka}", hxTarget = "main") { $"%i{row.Teczka}" }
                }
                td () { row.NazwaPlacowkiTrafiaZywnosc }
                // .. Some more table data cells
            }
    }
```
<img src="/img/orglist.png" style="width:375px; position: absolute; bottom: 10px; right:10px;">
---
transition: slide-up
layout: center
---

# HTMX example 3: Implementation details (2/2)

```fsharp
//router.fs
let summaries (readSummaries: ReadOrganizationSummaries) : EndpointHandler =
    fun ctx ->
        task {
            let filter = ctx |> parseFilter
            let! summaries = readSummaries filter
            return ctx.WriteHtmlView(ListTemplate.Template summaries)
        }
        
let Endpoints (dependencies: Dependencies) =
    [ GET
          [ route "/" indexPage
            route "/summaries" (summaries dependencies.ReadOrganizationSummaries)
            // ... more routes
          ]
      POST ...
    ]
```

---
transition: slide-up
layout: center
---

# HTMX example 4: Server Sent Events
<br/>
```html
<div hx-ext="sse" sse-connect="/event-source" sse-swap="EventName"></div>
```

---
transition: none
layout: center
class: text-center
---
# SPA Attack!

<img src="/img/state_asking.png" style="width:600px">

---
transition: none
layout: center
class: text-center
---
# SPA Attack!

<img src="/img/state_htmx.png" style="width:450px">

---
transition: none
layout: center
---
# Strategy 1: Expand the target
/organizations/list?search=jadłodajnia&sort=Teczka&dir=asc

<img src="/img/expand.png" style="width:800px">

---
transition: slide-up
layout: center
---
# Strategy 1: Expand the target
/organizations/list?search=jadłodajnia&sort=Teczka&dir=asc

<img src="/img/expand2.png" style="width:800px">

---
transition: none
layout: center
---
# Expand ur mum! I'm building a complex app here!

<img src="/img/amazon1.png" style="width:800px">


---
transition: slide-up
layout: center
---
# Expand ur mum! I'm building a complex app here!

<img src="/img/amazon2.png" style="width:800px">

---
transition: slide-up
layout: center
---
# Strategy 2: Out of band swaps


```html
<div>
 Item added to cart
</div>
<div id="cartItemsCount" hx-swap-oob="true">
    2
</div>
<div id="cartItemsPreview" hx-swap-oob="true">
    <li>
      ...
    </li>
    ...
</div>
```

---
transition: slide-up
layout: center
---
# Strategy 3: Events

```html
  <tbody id="contacts-table" hx-get="/contacts/table" hx-trigger="newContact from:body">
    ...
  </tbody>
```


<br/>
<br/>
HTTP/1.1 200 OK
```
HX-Trigger:newContact
```

---
transition: slide-up
layout: center
class: text-center
---
# Client side state summary:

<img src="/img/state_sad.png" style="width:600px">
---
transition: slide-up
layout: center
class: text-center
---

# A real success story
https://www.youtube.com/watch?v=3GObi93tjZI
<img src="/img/suc1.png" style="width:500px">

---
transition: slide-up
layout: center
class: text-center
---

# A real success story
https://www.youtube.com/watch?v=3GObi93tjZI
<img src="/img/suc2.png" style="width:500px">

---
transition: slide-up
layout: center
---

# Recent example from my work:
<img src="/img/febe.png" style="width:700px">

<!-- Separate tasks, separate PRs, kompatybilnosc, osobne testy, osobne CI/CD -->

---
transition: slide-up
layout: center
---

# Where to go next?
<img src="/img/rising_star.png" style="width:450px; position:absolute; top:100px; right:10px; transform:rotate(25deg);">
<img src="/img/book.jpg" style="width:200px">

https://htmx.org/ -> great "essays" section

Also see: https://htmx.org/essays/future/#no-new-features-as-a-feature

https://github.com/Good-Function/food-bank

---
transition: slide-up
layout: center
class: text-left
---

# Feedback time (2 minutes)

- Wejdź w agendę i kliknij w wybrany wykład
- Oceń prelekcję i napisz komentarz

<div style="text-align:center">
  <img src="/img/4devqr.png" style="width:300px; margin: 20px auto auto auto;">
</div>

---
transition: slide-up
layout: center
class: text-center
---

## We talked about:

<small style="text-align:left;">
<ol>
<li><b><<span color="blue">/</span>htm<span color="blue">x</span>></b> uses javascript so you don't have to.</li>
<li><b><<span color="blue">/</span>htm<span color="blue">x</span>></b> is a great way to build REST style systems. Most JSON APIs aren't REST.</li>
<li><b><<span color="blue">/</span>htm<span color="blue">x</span>></b> makes you to think about the fundamentals of Web development.</li>
<li>Learn <b><<span color="blue">/</span>htm<span color="blue">x</span>></b> once, use it with programming language you love.</li>
<li>With SSR and <b><<span color="blue">/</span>htm<span color="blue">x</span>></b> lack of client state managment is not a blocker.</li>
<li>With SSR and <b><<span color="blue">/</span>htm<span color="blue">x</span>></b> rich UI like active search, page transitions, fast navigation with good UX is possible and simple!</li>
<li>One app is simpler than 2 apps (versioning, localization, infra, deployments,...)</li>
</ol>
</small>

# Questions?