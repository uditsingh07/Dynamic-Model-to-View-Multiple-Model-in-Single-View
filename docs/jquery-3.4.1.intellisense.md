# jQuery IntelliSense

This script provides auto-completion and other features for the jQuery library.

## Usage

To use this script, include it in your project's scripts section.

javascript
require('./scripts/jquery-3.4.1.intellisense.js');


## Configuration Options

The script accepts an optional configuration object with the following properties:

### `path` {string} - The path to the jQuery library.

Example:

javascript
require('./scripts/jquery-3.4.1.intellisense.js', { path: '/path/to/jquery' });

