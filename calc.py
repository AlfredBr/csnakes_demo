def add(x: int, y: int) -> int:
    """Returns the sum of x and y."""
    return x + y

def sub(x: int, y: int) -> int:
    """Returns the difference of x and y."""
    return x - y

def mul(x: int, y: int) -> int:
    """Returns the product of x and y."""
    return x * y

def div(x: int, y: int) -> float:
    """Returns the quotient of x and y. Raises ValueError if y is zero."""
    if y == 0:
        raise ValueError("Cannot divide by zero.")
    return x / y
