# jQuery Validate Unobtrusive Min

The `jquery.validate.unobtrusive.min` script is a minimized version of the jQuery Validate plugin, optimized for use with ASP.NET MVC and other unobtrusive validation techniques.

## Usage

To use this script, include it in your HTML document before any form elements that require validation. The script will automatically attach validation rules to each form element using data attributes.

### Example
html
<form>
  <label for="username">Username:</label>
  <input type="text" id="username" name="username" data-validate="required, email">
</form>


## Configuration

The script uses a set of predefined validation rules that can be customized by adding additional data attributes to form elements. For example:
html
<form>
  <label for="password">Password:</label>
  <input type="password" id="password" name="password" data-validate="required, minlength(8)">
</form>

