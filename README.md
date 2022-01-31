# docker run rabbitmq
```
docker run -d --hostname my-rabbit --name rabbit13 -p 15672:15672 -p 5672:5672 -p 25676:25676 rabbitmq:3-management
```

```
docker run -p 15672:15672 -p 5672:5672 masstransit/rabbitmq
```