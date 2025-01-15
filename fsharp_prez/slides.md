---
background: ./flogo.png
title: Welcome to Good Function
class: text-center
drawings:
  persist: false
transition: slide-up
mdc: true
colorSchema: dark
---

# Welcome to Good Function

and the very first lecture!

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

<picture>
  <source srcset="https://fonts.gstatic.com/s/e/notoemoji/latest/1f917/512.webp" type="image/webp">
  <img src="https://fonts.gstatic.com/s/e/notoemoji/latest/1f917/512.gif" alt="🤗" width="300" height="300">
</picture>

---

# Shiki Magic Move

Powered by [shiki-magic-move](https://shiki-magic-move.netlify.app/), Slidev supports animations across multiple code snippets.

Add multiple code blocks and wrap them with <code>````md magic-move</code> (four backticks) to enable the magic move. For example:

````md magic-move {lines: true}
```ts {2}
// step 1
const author = reactive({
  name: "John Doe",
  books: [
    "Vue 2 - Advanced Guide",
    "Vue 3 - Basic Guide",
    "Vue 4 - The Mystery",
  ],
});
```

```ts {3-4}
// step 1
const author = reactive({
  name: "John Doe",
  books: [
    "Vue 2 - Advanced Guide",
    "Vue 3 - Basic Guide",
    "Vue 4 - The Mystery",
  ],
});
```

```ts
// step 1
const author = reactive({
  name: "John Doe",
  books: [
    "Vue 2 - Advanced Guide",
    "Vue 3 - Basic Guide",
    "Vue 4 - The Mystery",
  ],
});
```
````

---

<Tweet id="1854994763164139923" scale="0.85" />

---

---

# Questions?

<Toc columns="3"/>
