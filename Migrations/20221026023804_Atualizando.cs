using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace marcondes.Migrations
{
    public partial class Atualizando : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes");

            migrationBuilder.RenameTable(
                name: "Clientes",
                newName: "cliente");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "cliente",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Identidade",
                table: "cliente",
                newName: "identidade");

            migrationBuilder.RenameColumn(
                name: "Estado",
                table: "cliente",
                newName: "estado");

            migrationBuilder.RenameColumn(
                name: "Endereco",
                table: "cliente",
                newName: "endereco");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "cliente",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Cpf",
                table: "cliente",
                newName: "cpf");

            migrationBuilder.RenameColumn(
                name: "Cidade",
                table: "cliente",
                newName: "cidade");

            migrationBuilder.RenameColumn(
                name: "Cep",
                table: "cliente",
                newName: "cep");

            migrationBuilder.RenameColumn(
                name: "Celular",
                table: "cliente",
                newName: "celular");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "cliente",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "NomeSocial",
                table: "cliente",
                newName: "nome_social");

            migrationBuilder.RenameColumn(
                name: "DataNascimento",
                table: "cliente",
                newName: "data_nascimento");

            migrationBuilder.AddPrimaryKey(
                name: "PK_cliente",
                table: "cliente",
                column: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_cliente",
                table: "cliente");

            migrationBuilder.RenameTable(
                name: "cliente",
                newName: "Clientes");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Clientes",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "identidade",
                table: "Clientes",
                newName: "Identidade");

            migrationBuilder.RenameColumn(
                name: "estado",
                table: "Clientes",
                newName: "Estado");

            migrationBuilder.RenameColumn(
                name: "endereco",
                table: "Clientes",
                newName: "Endereco");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Clientes",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "cpf",
                table: "Clientes",
                newName: "Cpf");

            migrationBuilder.RenameColumn(
                name: "cidade",
                table: "Clientes",
                newName: "Cidade");

            migrationBuilder.RenameColumn(
                name: "cep",
                table: "Clientes",
                newName: "Cep");

            migrationBuilder.RenameColumn(
                name: "celular",
                table: "Clientes",
                newName: "Celular");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Clientes",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "nome_social",
                table: "Clientes",
                newName: "NomeSocial");

            migrationBuilder.RenameColumn(
                name: "data_nascimento",
                table: "Clientes",
                newName: "DataNascimento");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes",
                column: "Id");
        }
    }
}
