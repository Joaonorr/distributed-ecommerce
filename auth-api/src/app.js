import express from 'express';
import * as db from './config/initialData.config.js'
import UserRoutes from './routes/User.routes.js'

// Create a new express application instance
const app = express();
const env = process.env;
const PORT = env.PORT || 8082;

// Create initial data
db.CreateInitialData();

// Configure express to use body-parser as middleware.
app.use(express.json());

// Configure express to use router
app.use('/api/v1', UserRoutes)

// Up server
app.listen(PORT, () => {
    console.log(`Server is running on port ${PORT}`);
});
