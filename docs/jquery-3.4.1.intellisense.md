# jQuery IntelliSense

This script provides auto-completion and code snippet suggestions for jQuery functions, variables, and properties.

## Usage

To use this script, include it in your HTML file before the closing `</body>` tag:

html
<script src="scripts/jquery-3.4.1.intellisense.js"></script>
</body>
</html>

## Configuration Options

The script can be customized by passing options to the `intellisense` function, such as:

javascript
intellisense({
  theme: 'light',
  ignoreList: ['$.ajax']
});

