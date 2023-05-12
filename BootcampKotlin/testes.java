import java.util.Scanner;

public class testes {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        // Leitura do salário e dos benefícios
        double salarioBruto = input.nextDouble();
        double beneficios = input.nextDouble();

        double imposto = 0;
        //TODO: Implemente as regras para o cálculo do imposto.
        if (salarioBruto <= 1100){
            imposto = salarioBruto * 0.05;
        } else if (salarioBruto>1100.01 && salarioBruto<=2500) {
            imposto = salarioBruto * 0.10;
        } else {
            imposto = salarioBruto * 0.15;
        }

        double salarioLiquido = salarioBruto - imposto + beneficios;
        System.out.printf("%.2f",salarioLiquido);

        //TODO: Imprimir o salário líquido com 2 casas decimais.
    }
}







/*    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.println("Digite sua Idade");
        double idadeTerrestre = scanner.nextDouble();
        System.out.println("Digite o Planeta (Marte, Venus e Jupiter)");
        String planeta = scanner.next();
        String marte = String.format("%.2f", idadeTerrestre / 1.88);
        String venus = String.format("%.2f", idadeTerrestre / 0.62);
        String jupiter = String.format("%.2f", idadeTerrestre / 11.86);

        if(planeta.equals("Marte")) {
            System.out.println("Idade equivalente em Marte: "+ marte + " anos");
        }else if (planeta.equals("Venus")) {
            System.out.printf("Idade equivalente em Venus: " + venus + " anos");
        }else if (planeta.equals("Jupiter")) {
            System.out.printf("Idade equivalente em Jupiter: " + jupiter + " anos");
        }else {
            System.out.println("Planeta Invalido");
        }
        scanner.close();

    }
}*/
