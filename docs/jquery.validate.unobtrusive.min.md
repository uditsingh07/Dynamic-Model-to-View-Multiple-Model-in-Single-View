## jQuery Validation Unobtrusive

The `jquery.validate.unobtrusive.min.js` script provides a client-side validation plugin that works seamlessly with ASP.NET MVC.

### Usage

To use this plugin, include the following code in your `<head>` section:

html
<script src="@Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js")" type="text/javascript"></script>


### Validation Attributes

The `jquery.validate.unobtrusive.min.js` script uses validation attributes to define the rules for form fields. The following attributes are supported:

*   `data-val`: Specifies that a field should be validated.
*   `data-val-required`: Specifies that a required value is needed for the field.
*   `data-val-email`: Specifies that an email address is required for the field.
*   `data-val-url`: Specifies that a URL is required for the field.

### Example Usage

html
<div>
    <input type="text" id="name" name="name" data-val="true" data-val-required="Please enter your name.">
</div>


This example demonstrates how to use the `data-val` and `data-val-required` attributes to specify that a field should be validated and that it is required.
