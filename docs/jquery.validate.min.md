# jQuery Validate

The jQuery Validate plugin is a client-side validation library for HTML forms.

## Features
- Validates form fields against a set of rules
- Supports various validation methods (e.g. email, URL, phone)
- Customizable error messages and validation messages

### Example Usage
html
<form id="myForm">
  <label for="name">Name:</label>
  <input type="text" id="name" name="name" required>
  <button type="submit">Submit</button>
</form>

<script src="https://cdn.jsdelivr.net/npm/jquery-validation@1.19.3/dist/jquery.validate.min.js"></script>
<script>
  $(document).ready(function() {
    $('#myForm').validate({
      rules: {
        name: 'required'
      }
    });
  });
</script>