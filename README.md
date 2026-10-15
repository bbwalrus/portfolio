# Personal Portfolio Website

An Astro portfolio showcasing my software engineering and data science projects, technologies, and background.

## Local development

```sh
npm install
npm run dev
```

Create a production build and preview it locally:

```sh
npm run build
npm run preview
```

## Deploying to Netlify

The repository includes `netlify.toml` with the Astro production build command and `dist` publish directory. In Netlify, import this project and use the project directory as the base directory; the build settings will be detected from that file. Netlify installs dependencies from `package-lock.json` and publishes the generated `dist` directory.
