- Inversão da dependência (Dependency Inversion).

- Essa é uma aplicação que deverá ser na direção da abstração e não nos detalhes de implementação.
   - Modulos de alto nivel não devem depender de modulos de baixo nivel. Ambos devem depender de uma abstração.
     - Abstração não devem depender de detalhes. Detalhes devem depender de abstração.

- Modulos de alto nivel são classes da camada de negócios que encapsulam uma lógica complexa.
- Modulos de baixo nivel são classes da camada de infraestrutura que implementam operações básicas como acesso a dados, ao disco, protocolos de rede, etc.
- As abstrações seriam interfaces ou class abstract que não possuem implementação.

- Assim, as classes da camada de negócio não devem depender das classes da camada de infraestutura, mas ambas devem depender de uma interface ou class abstract. 
