import React, {Component} from 'react';
import GitHubCorner from './GitHubCorner'

class InfoAboutApp extends Component {
  render() {
    return (
      <React.Fragment>

        <div>
          <GitHubCorner />
          <h1 className="App-title">Calculator</h1>
        </div>
      </React.Fragment>
  )}
}

export default InfoAboutApp;