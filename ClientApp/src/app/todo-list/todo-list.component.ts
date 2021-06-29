import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ToDo, ToDoPriority } from '../models/ToDo';

@Component({
  selector: 'app-todo-list',
  templateUrl: './todo-list.component.html'
})
export class TodoListComponent {
  public todos: ToDo[];
  public isLoading: boolean = false;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<ToDo[]>(baseUrl + 'todolist').subscribe(result => {
      // for display purposes, we convert the ordinal enum value to its string name.
      result.every(x => x.priority = ToDoPriority[x.priority]);

      this.todos = result;
    }, error => console.error(error));
  }
}
