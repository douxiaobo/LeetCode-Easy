public class Solution {  
    public double[] convertTemperature(double celsius) {  
        double kelvin = celsius + 273.15;  
        double fahrenheit = celsius * 1.8 + 32;  
        return new double[]{kelvin, fahrenheit};  
    }  
  
    public static void main(String[] args) {  
        Solution solution = new Solution();  
        double[] temperatures = solution.convertTemperature(0.0);  
        System.out.println("[" + temperatures[0] + ", " + temperatures[1] + "]");  
    }  
}