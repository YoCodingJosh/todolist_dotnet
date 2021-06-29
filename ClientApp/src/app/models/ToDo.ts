export enum ToDoPriority {
  Low = 0,
  Normal,
  High
}

export interface ToDo {
  id: number;
  title: string;
  description: string;
  priority: string;
}
