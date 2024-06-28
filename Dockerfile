# syntax=docker/dockerfile:1
FROM golang:1.19
WORKDIR /Resources/RTSPtoWebRTC
COPY . .

# Install dependencies (if needed)
RUN go mod download

RUN go build .

EXPOSE 8083

CMD ["./myapp"]
