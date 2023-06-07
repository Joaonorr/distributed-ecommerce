FROM gradle:8.1.1-jdk17
COPY --chown=gradle:gradle . /app
WORKDIR /app
RUN gradle build 
EXPOSE 8081
CMD ["gradle", "bootRun"]