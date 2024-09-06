public class Main {
    public static void main(String[] args) {
        String creditCard = "Credit_Card_Number";
        String[] chunks = creditCard.split(" ");
        
        int totalSum = 0;
        for (String chunk : chunks) {
            totalSum += getChunkSum(chunk);
        }
        
        System.out.println(totalSum % 10 == 0);
    }
    
    private static int getChunkSum(String chunk) {
        int sum = 0;
        boolean isDouble = false;
        
        for (int i = chunk.length() - 1; i >= 0; i--) {
            int digit = Character.getNumericValue(chunk.charAt(i));
            
            if (isDouble) {
                digit *= 2;
                if (digit > 9) digit -= 9;
            }
            
            sum += digit;
            isDouble = !isDouble;
        }
        
        return sum;
    }
}
