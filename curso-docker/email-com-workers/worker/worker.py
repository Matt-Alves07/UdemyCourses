import redis
import json
from time import sleep
from random import randint

if __name__ == '__main__':
    r = redis.Redis(host='queue',port=6379,db=0)
    while True:
        mensagem = json.loads(r.blpop('sender')[1])
        #simulating e-mail sending.....
        print('Enviando a mensage:', mensage['assunto'])
        sleep(randint(5,15))
        print('Mensagem ', mensagem['assunto'], ' enviada.')