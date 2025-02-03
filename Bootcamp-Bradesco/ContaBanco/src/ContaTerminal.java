import java.sql.SQLOutput;
import java.util.Scanner;

public class ContaTerminal {
    public static void main(String[] args) {
        int numero;
        String nomeCliente, agencia;
        double saldo;

        Scanner scan = new Scanner(System.in);

        System.out.println("Por favor, digite o número da Agência: ");
        agencia = scan.nextLine();
        System.out.println("Por favor, digite o número da conta do cliente: ");
        numero = scan.nextInt();
        System.out.print("Por favor, digite o nome do Cliente: ");
        nomeCliente = scan.next();
        System.out.println("Por favor, digite o saldo do Cliente: ");
        saldo = scan.nextDouble();
        System.out.println("Olá, " + nomeCliente + ", obrigado por criar uma conta em nosso banco, sua agência é "
                           + agencia + ", conta " + numero + " e seu saldo é R$ " + saldo + " já está disponível para saque.");

    }

}