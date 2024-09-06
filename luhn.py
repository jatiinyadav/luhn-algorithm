def get_chunk_sum(chunk):
    total_sum = 0
    is_double = False
    
    for digit in reversed(chunk):
        digit = int(digit)
        
        if is_double:
            digit *= 2
            if digit > 9:
                digit -= 9
        
        total_sum += digit
        is_double = not is_double

    return total_sum

credit_card = "Credit_Card_Number"
chunks = credit_card.split()
total_sum = sum(get_chunk_sum(chunk) for chunk in chunks)

print(total_sum % 10 == 0)
