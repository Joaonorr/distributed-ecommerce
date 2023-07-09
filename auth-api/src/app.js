import express from 'express';
import * as db from './config/InitialDataConfig.js'
import UserRoutes from './routes/UserRoutes.js'
import dotenv from 'dotenv'

// Create a new express application instance
const app = express();
const env = process.env;
const PORT = env.PORT || 8082;

dotenv.config();

// Create initial data
db.CreateInitialData();

// Configure express to use body-parser as middleware.
app.use(express.json());

// Configure express to use router
app.use('/api/v1/user', UserRoutes)

// Up server
app.listen(PORT, () => {
    console.log(`Server is running on port ${PORT}`);
});
