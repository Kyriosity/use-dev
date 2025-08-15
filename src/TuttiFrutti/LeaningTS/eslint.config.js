module.exports = [
    {
        rules: {
            '@typescript-eslint/no-unused-vars': 'off',
            "no-unused-vars": ["off", {
                "vars": "all",
                "args": "after-used",
                "caughtErrors": "all",
                "ignoreRestSiblings": false,
                "reportUsedIgnorePattern": false
            }]
        }
    }
];