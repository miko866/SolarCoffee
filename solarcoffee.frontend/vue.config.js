/*
 *  Vue Config
 */

module.exports = {
  productionSourceMap: false,
  devServer: {
    host: "0.0.0.0",
    port: 3200,
    https: false,
    disableHostCheck: true
  },
  runtimeCompiler: true
};
