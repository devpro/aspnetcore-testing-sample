var path = require('path');

module.exports = {
  entry: {
    main: './wwwroot/js/site.js'
  },
  output: {
    path: path.join(__dirname, '/wwwroot/js/dist'),
    filename: 'vendor.js'
  }
};
