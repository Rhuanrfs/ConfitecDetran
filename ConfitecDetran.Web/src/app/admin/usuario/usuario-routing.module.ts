import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { ListarComponent } from './listar/listar.component';
import { IncluirComponent } from './incluir/incluir.component';

export const routes: Routes = [
  { path: '', component: ListarComponent },
  { path: 'listar', component: ListarComponent },
  { path: 'incluir', component: IncluirComponent },
  { path: 'editar:id', component: IncluirComponent },
];


@NgModule({
  declarations: [ListarComponent],
  imports: [
    CommonModule,
    RouterModule.forChild(routes),
  ]
})
export class UsuarioRoutingModule { }
