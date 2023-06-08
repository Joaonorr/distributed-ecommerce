import { Sequelize } from "sequelize";

const USER = process.env.POSTGRES_USER || "admin";
const PASSWORD = process.env.POSTGRES_PASSWORD || "123456";

const dbContext = new Sequelize("auth-db", USER, PASSWORD, {
    host: "localhost",
    dialect: "postgres",
    define: {
        syncOnAssociation: true,
        timestamps: false,
        underscored: true,
        underscoredAll: true,
        freezeTableName: true,
    },
});

dbContext.authenticate().then(() => {
    console.log("Connection with DB auth has been established successfully.");
}).catch((err) => {
    console.error("Unable to connect to the auth database:", err);
})

export default dbContext;

