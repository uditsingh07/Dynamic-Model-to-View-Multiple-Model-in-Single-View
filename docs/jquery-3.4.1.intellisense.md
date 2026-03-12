# jQuery IntelliSense

This script provides IntelliSense functionality for jQuery versions 3.4.1.

## Usage

To use this script, include it in your project's JavaScript file and call the `init()` function to enable IntelliSense.

javascript
var jsIntellisense = require('./jquery-3.4.1.intellisense.js');
jsIntellisense.init();


## Configuration Options

The script accepts an optional configuration object with the following properties:

* `language`: The programming language to use for IntelliSense suggestions.
* `threshold`: The minimum number of characters required for a suggestion to be displayed.

javascript
var config = {
  language: 'js',
  threshold: 2
};
jsIntellisense.init(config);

