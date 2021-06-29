import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-todo-list',
  templateUrl: './todo-list.component.html'
})
export class TodoListComponent {
  public todos: ToDo[];
  public isLoading: boolean = false;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    // http.get<WeatherForecast[]>(baseUrl + 'weatherforecast').subscribe(result => {
    //   this.forecasts = result;
    // }, error => console.error(error));
  }
}

// TODO: Move me to a separate file!
interface ToDo {
  title: string;
  description: string;
}
