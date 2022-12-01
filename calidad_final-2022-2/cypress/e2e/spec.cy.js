describe('Examen Final', () => {
  it('Generar Naipes', () => {
    cy.visit(Cypress.env('base_url'))
    cy.get('#boton').click()
    cy.location('pathname').should('eq','/home/generar')
  })
  it('Entrar Privacy', () => {
    cy.visit(Cypress.env('base_url'))
    cy.get('#privacy').click()
    cy.location('pathname').should('eq','/Home/Privacy')
  })
  it('Entrar Privacy2', () => {
    cy.visit(Cypress.env('base_url'))
    cy.get('#privacy2').click()
    cy.location('pathname').should('eq','/Home/Privacy')
  })
})