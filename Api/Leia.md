# ForLearn

Este projeto é uma Web Api desenvolvida em C# e ASP.net onde:

"PK" é sempre primary key de cada tabela e não é necessário ser informado em requisições do tipo Post

Segue com base na Regra:

 “O RH necessita de uma aplicação para traçar as tecnologias que os candidatos conhecem. Como cadastros base, será 
 informado ao sistema quais tecnologias a empresa trabalha, e quais vagas estão disponíveis. Durante a entrevista, 
 candidato será cadastrado a uma vaga e vinculado às tecnologias que conhece. Ao final do período de triagem de 
 currículos, o RH informará o peso de cada tecnologia para a vaga em questão, recebendo com isso, um relatório 
 ordenado por candidato, pontuado de acordo com o conhecimento do mesmo.”
 
 A documentação de como consumir esta Web Api está na prórpia.
 
 Para ser cadastrado uma habilidade para empresa deverá ser chamado: url + api/EmpresaH
 
 Para ser cadastrado as vagas deverá ser chamado: url + api/vagas
 
 Para ser cadastrado um candidato deverá ser chamado: url + api/candidatos
 
 Também será necessário atribuir a cada candidato habilidades por meio de: url + api/candidatoshabilidade
 Obs: 
  FkCand é o Pk do candidato (api/candidatos)
  FkCadEmpresaH é o Pk da habilidade da empresa (api/EmpresaH)
 
 Para ser cadastrado o Peso que cada vaga possui deverá ser chamado por: url + api/peso
 Obs:
  FkVaga é o Pk da vaga (api/vagas)
  FkCadEmp é o Pk da habilidade da empresa (api/EmpresaH)
  
  Para se obter resultado final do processo seletivo é só chamar: url + api/resultado
  
  Lembrando, consultar documentação da API
