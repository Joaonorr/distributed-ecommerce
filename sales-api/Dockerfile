FROM node:20
WORKDIR /usr/src/app
COPY package*.json ./
RUN yarn
COPY . .
EXPOSE 8083
CMD ["node", "src/app.js"]