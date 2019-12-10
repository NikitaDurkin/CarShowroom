const path = require('path');
const ExtractTextPlugin = require('extract-text-webpack-plugin');
const HtmlWebpackPlugin = require('html-webpack-plugin');

module.exports = {
  mode: 'development',
  entry: { main: path.resolve(__dirname, 'src', 'index.js') },
  output: {
    path: path.join(__dirname, '..', 'CarShowroom.API', 'wwwroot'),
    filename: 'index-bundle.js',
    publicPath: '/',
  },
  performance: {
    hints: false
  },
  resolve: {
    extensions: ['.js', '.jsx'],
  },
  module: {
    rules: [
      {
        test: /\.(js|jsx)$/,
        exclude: /node_modules/,
        use: {
          loader: 'babel-loader',
        },
      },
      {
        test: /\.css$/,
        use: ExtractTextPlugin.extract(
          {
            fallback: 'style-loader',
            use: ['css-loader'],
          },
        ),
      },
    ],
  },
  plugins: [
    new ExtractTextPlugin(
      { filename: 'index.css' },
    ),
    new HtmlWebpackPlugin({
      inject: 'body',
      hash: true,
      template: './src/index.html',
      filename: 'index.html',
    }),
  ],

  devServer: {
    contentBase: path.join(__dirname, '..', 'CarShowroom.API', 'wwwroot'),
    port: 9000,
    compress: true,
    watchContentBase: true,
    open: true,
    writeToDisk: true
  }
};
