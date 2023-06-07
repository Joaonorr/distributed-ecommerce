import express from 'express';

const app = express();
const env = process.env
const PORT = env.PORT || 8083;

app.get('/api/status', (req, res) => {
    res.send({ status: 'ok' });
});

app.listen(PORT, () => {
    console.log(`Server listening on port ${PORT}...`);
});