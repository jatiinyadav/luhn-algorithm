const creditCard = "Credit_Card_Number";

const getChunkSum = (chunk) => {
    let sum = 0;
    let isDouble = false;

    for (let i = chunk.length - 1; i >= 0; i--) {
        let digit = Number(chunk[i]);

        if (isDouble) {
            digit *= 2;
            if (digit > 9) digit -= 9;
        }

        sum += digit;
        isDouble = !isDouble;
    }

    return sum;
};

const totalSum = creditCard.split(" ").reduce((acc, chunk) => acc + getChunkSum(chunk), 0);

console.log(totalSum % 10 === 0);
