import express from 'express';

const app = express();
const env = process.env;
const PORT = env.PORT || 8082;

app.get('/', (req, res) => {
    res.send('Hello World!');
});

app.listen(PORT, () => {
    console.log(`Server is running on port ${PORT}`);
});
