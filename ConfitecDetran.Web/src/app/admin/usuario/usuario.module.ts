import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ListarComponent } from './listar/listar.component';
import { UsuarioRoutingModule } from './usuario-routing.module';
import { IncluirComponent } from './incluir/incluir.component';



@NgModule({
  declarations: [
  
    IncluirComponent
  ],
  imports: [
    CommonModule,
    UsuarioRoutingModule,
  ]
})
export class UsuarioModule { }
