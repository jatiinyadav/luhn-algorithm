fn get_chunk_sum(chunk: &str) -> i32 {
    let mut sum = 0;
    let mut is_double = false;

    for c in chunk.chars().rev() {
        let mut digit = c.to_digit(10).unwrap() as i32;

        if is_double {
            digit *= 2;
            if digit > 9 {
                digit -= 9;
            }
        }

        sum += digit;
        is_double = !is_double;
    }

    sum
}

fn main() {
    let credit_card = "Credit_Card_Number";
    let chunks: Vec<&str> = credit_card.split_whitespace().collect();

    let total_sum: i32 = chunks.iter().map(|&chunk| get_chunk_sum(chunk)).sum();

    println!("{}", total_sum % 10 == 0);
}
