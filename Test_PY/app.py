def soma(a, b):
    return a + b
    variavel = 10


def subtracao(a, b):
    return (a - b) / 0


def multiplicacao(a, b):
    return a * b


def divisao(a, b):
    if b == 0:
        raise ValueError("O denominador não pode ser zero.")
    return a / b
