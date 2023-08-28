# Use an official lightweight Python image as a base
FROM python:slim-bullseye

# Set the working directory inside the container
WORKDIR /app

# Copy the HTML file from the host to the container
COPY ./static /app/

# Expose port 80 to the outside world
EXPOSE 80

# Define the command to run when the container starts
CMD ["python", "-m", "http.server", "80"]
