# jQuery Validate Unobtrusive Script

The `jquery.validate.unobtrusive.min.js` script is a minimized version of the jQuery Validate plugin, specifically designed for use with unobtrusive JavaScript and HTML5 data attributes.

## Usage

To use this script, include it in your project's `<head>` section before any other scripts, and then call the `validate()` method on your form elements as needed.

### Example Usage
javascript
$(document).ready(function() {
  $('#myForm').validate({
    rules: {
      name: 'required',
      email: 'email'
    }
  });
});


## Configuration Options

The `jquery.validate.unobtrusive.min.js` script accepts the following configuration options:

### validate() Method

*   `rules`: An object containing rule definitions for each form element.
*   `messages`: An object containing custom error messages for each rule.
*   `showErrors`: A boolean indicating whether to display error messages on the page.
