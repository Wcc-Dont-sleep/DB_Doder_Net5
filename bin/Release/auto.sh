image="backend"
container="backendcontainer"

docker stop ${container}
docker rm ${container}

docker rmi ${image}

docker build -t ${image} .

docker run -d --name ${container} -p 8021:10957 ${image}
