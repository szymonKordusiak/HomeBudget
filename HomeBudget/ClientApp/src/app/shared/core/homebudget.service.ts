import { Injectable } from '@angular/core';
import { Income } from './types/income.models';

@Injectable({
  providedIn: 'root'
})
export class HomebudgetService {

    public income: Income[] = [
        {"Id": 1, "Name": "Wypłata", "Value": 5000},
        {"Id": 2, "Name": "Sprzedaż", "Value": 1000}, 
    ]

    getIncome():Income[]{
        return this.income;
    }
    

  constructor() { }
}
