#### Install docker desktop  
https://www.docker.com/products/docker-desktop

#### Build image https://docs.docker.com/engine/reference/commandline/build/  
`docker build -t prometheus-test -f Dockerfile .`

#### Run container https://docs.docker.com/engine/reference/commandline/run/  
`docker run -d -p 80:80 --name=p-t-w-c prometheus-test-web`
or
`docker run -it --rm -p 80:80 --name=p-t-w-c prometheus-test-web`

#### Connect to container with bash https://docs.docker.com/engine/reference/commandline/exec/
`docker exec -ti p-t-c bash`
