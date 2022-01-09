// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

//codemirror
var schema = CodeMirror.fromTextArea(document.getElementById('Schema'), {
    matchBrackets: true,
    lineNumbers: true,
    lineWrapping: true,
    mode: "application/ld+json",
    viewportMargin: Infinity
});

schema.setOption('theme', 'paraiso-dark');
schema.setSize(500, 400);

var data = CodeMirror.fromTextArea(document.getElementById('Data'), {
    matchBrackets: true,
    lineNumbers: true,
    autoCloseBrackets: true,
    mode: "application/ld+json",
    viewportMargin: Infinity
});

data.setOption('theme', 'paraiso-dark');
data.setSize(500, 400);
