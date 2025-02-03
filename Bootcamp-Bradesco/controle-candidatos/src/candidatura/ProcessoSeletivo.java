package candidatura;

import java.util.ArrayList;
import java.util.Random;
import java.util.concurrent.ThreadLocalRandom;

public class ProcessoSeletivo {
    static double salarioBase = 2000.0; // Declarar apenas uma vez
    static ArrayList<String> candidatosSelecionados = new ArrayList<>(); // Lista para armazenar os selecionados

    public static void main(String[] args) {
        selecaoCandidatos(); // Selecionar os candidatos
        imprimirSelecionados();// Imprimir os candidatos selecionados
        entrandoEmContato();

    }

    static void selecaoCandidatos(){
        String[] candidatos = {"MARCIA", "DANIELA", "MICHELLE", "JOAO", "ROBERTO", "JULIANA", "ODAIR", "FABRICIO", "GIOVANNA"};

        // Contador para limitar a seleção a 5 candidatos
        int candidatosSelecionadosCount = 0;

        for (int i = 0; i < candidatos.length && candidatosSelecionadosCount < 5; i++) {
            String candidato = candidatos[i];
            double salarioPretendido = valorPretendido();
            System.out.println("O candidato " + candidato + " solicitou este valor de salário R$ " + salarioPretendido);

            // Verifica se o salário base é maior ou igual ao salário pretendido
            if (salarioBase >= salarioPretendido) {
                System.out.println("Candidato Selecionado: " + candidato);
                candidatosSelecionados.add(candidato); // Adiciona o candidato selecionado
                candidatosSelecionadosCount++; // Incrementa o contador de selecionados
            } else {
                analisarCandidatos(salarioPretendido, candidato); // Chama análise do candidato
            }
        }
    }

    // Método que retorna o valor do salário pretendido aleatoriamente entre R$1800 e R$2200
    static double valorPretendido(){
        return ThreadLocalRandom.current().nextDouble(1800, 2200);
    }

    // Imprimir a lista de candidatos selecionados
    static void imprimirSelecionados() {
        System.out.println("\nCandidatos Selecionados: ");
        if (candidatosSelecionados.isEmpty()) {
            System.out.println("Nenhum candidato selecionado.");
        } else {
            for (String candidato : candidatosSelecionados) {
                System.out.println(candidato);
            }
        }
    }

    static void entrandoEmContato() {
        System.out.println("Entrando em contato com o candidato selecionado: ");
        for (String candidato : candidatosSelecionados) {
            int tentativasRealizadas = 1;
            boolean continuarTentando = true;
            boolean atendeu = false;

            // Tentativas de contato (máximo 3 tentativas)
            do {
                atendeu = atender(); // Verifica se atendeu
                if (atendeu) {
                    System.out.println("Conseguimos contato com " + candidato + " na " + tentativasRealizadas + "ª tentativa.");
                } else {
                    System.out.println("Tentativa " + tentativasRealizadas + " não teve sucesso com " + candidato);
                    tentativasRealizadas++;
                }
                continuarTentando = !atendeu && tentativasRealizadas < 3;
            } while (continuarTentando);

            // Caso não tenha conseguido entrar em contato após 3 tentativas
            if (!atendeu) {
                System.out.println("Não conseguimos contato com " + candidato + " após 3 tentativas.");
            }
        }
    }
    static boolean atender(){
        return new Random().nextInt(3) == 1;
    }

    // Análise do candidato com base no salário pretendido
    static void analisarCandidatos(double salarioPretendido, String candidato){
        if (salarioBase > salarioPretendido) {
            System.out.println("Ligar para " + candidato + " (SALÁRIO PRETENDIDO ABAIXO DO VALOR DE MERCADO).");
        } else if (salarioBase == salarioPretendido) {
            System.out.println("Ligar para " + candidato + " com a contra proposta.");
        } else {
            System.out.println("Aguardar resultado dos demais candidatos para " + candidato + ".");
        }
    }
}
