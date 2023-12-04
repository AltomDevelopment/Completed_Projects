const express = require("express");
const app = express();
const db = require("./src/js/models");
const initRoutes = require("./src/js/routes/web");
const path = require("path");

global.__basedir = __dirname;

var publicassets = path.join(__dirname + '/public');

app.use(express.static(publicassets));

app.use(express.urlencoded({ extended: true }));
initRoutes(app);

db.sequelize.sync();
//In development, you may need to drop existing tables and re-sync database. Just use force: true as following code:
// db.sequelize.sync({ force: true }).then(() => {
//   console.log("Drop and re-sync db.");
// });

let port = 3000;
app.listen(port, () => {
  console.log(`Running at localhost:${port}`);
});

//node src/server.js