import { Component, Inject } from '@angular/core';
import { Sort } from '@angular/material/sort';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})

export class FetchDataComponent {
  public forecasts: WeatherForecast[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<WeatherForecast[]>(baseUrl + 'api/SampleData/WeatherForecasts').subscribe(result => {
      this.forecasts = result;
    }, error => console.error(error));
  }

  public sortData(sort: Sort) {
    const data = this.forecasts.slice();
    if (!sort.active || sort.direction === '') {
      this.forecasts = data;
      return;
    }

    this.forecasts = data.sort((a, b) => {
      const isAsc = sort.direction === 'asc';
      switch (sort.active) {
        case 'Date': return compare(a.dateFormatted, b.dateFormatted, isAsc);
        case 'Temp. (C)': return compare(a.temperatureC, b.temperatureC, isAsc);
        case 'Temp. (F)': return compare(a.temperatureF, b.temperatureF, isAsc);
        case 'Summary': return compare(a.summary, b.summary, isAsc);
        default: return 0;
      }
    });
  }
}

function compare(a: number | string, b: number | string, isAsc: boolean) {
  return (a < b ? -1 : 1) * (isAsc ? 1 : -1);
}

interface WeatherForecast {
  dateFormatted: string;
  temperatureC: number;
  temperatureF: number;
  summary: string;
}
