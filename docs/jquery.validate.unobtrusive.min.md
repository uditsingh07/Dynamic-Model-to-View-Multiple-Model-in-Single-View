## jQuery Validation Unobtrusive

The `jquery.validate.unobtrusive.min.js` script is a minimized version of the jQuery validation plugin, specifically designed for use with unobtrusive JavaScript.

### Usage

To use this script, include it in your HTML file before any form elements that require validation. The script will automatically attach validation functionality to these elements.

html
<form>
  <input type='text' name='username'/>
</form>

<script src='jquery.validate.unobtrusive.min.js'></script>

<script>
  $(document).ready(function() {
    $('#username').validate({
      rules: {
        username: 'required'
      }
    });
  });
</script>

</form>
