module.exports = {
    content: [
        "./src/Nagano98.Client/.fable-build/**/*.{js,ts,jsx,tsx}",
    ],
    plugins: [
        require('daisyui'),
    ],
    // daisyUI config (optional)
    daisyui: {
        themes: false,
    }
}
