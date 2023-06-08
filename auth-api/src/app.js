import express from 'express';
import * as db from './config/initialData.config.js'

const app = express();
const env = process.env;
const PORT = env.PORT || 8082;

db.CreateInitialData();

app.get('/', (req, res) => {
    res.send('Hello World!');
});

app.listen(PORT, () => {
    console.log(`Server is running on port ${PORT}`);
});
