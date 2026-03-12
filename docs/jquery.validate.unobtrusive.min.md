## jQuery Validate Unobtrusive

The `jquery.validate.unobtrusive.min.js` script provides a way to validate form inputs without requiring explicit JavaScript code.

### Usage
javascript
$.validator({
  // validation rules
});


### Validation Rules
The following validation rules are supported:
* `required`: checks if the input is required
* `email`: checks if the input is a valid email address
* `url`: checks if the input is a valid URL

### Example Usage
html
<form>
  <input type='text' id='username' name='username'>
  <button type='submit'>Submit</button>
</form>

<script src='scripts/jquery.validate.unobtrusive.min.js'></script>
<script>
$.validator(
  {
    rules: {
      username: 'required email'
    }
  }
)
  .on('submit', function(event) {
    if (!this.validate().isValid()) {
      event.preventDefault();
    }
  });
</script>

