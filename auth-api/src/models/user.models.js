import { Sequelize } from "sequelize";
import dbContext from "../config/db.config.js";

const User = dbContext.define("User", {
    id: {
        type: Sequelize.INTEGER,
        primaryKey: true,
        autoIncrement: true
    },
    userName: {
        type: Sequelize.STRING(255),
        allowNull: false,
    },
    email: {
        type: Sequelize.STRING(255),
        allowNull: false,
        unique: true
    },
    password: {
        type: Sequelize.STRING(255),
        allowNull: false,
    },
    createdAt: {
        type: Sequelize.DATE,
        allowNull: false,
        defaultValue: Sequelize.NOW
    }
},{});

export default User;