module.exports = {
    content: [
        "./src/Hlasky.Client/.fable-build/**/*.{js,ts,jsx,tsx}",
    ],
    plugins: [
        require('daisyui'),
    ],
    // daisyUI config (optional)
    daisyui: {
        themes: false,
    }
}
