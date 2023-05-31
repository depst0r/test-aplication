import React from 'react';
import Container from "react-bootstrap/Container";
import Row from "react-bootstrap/Row";
import { Route } from 'react-router';

import { Cards } from './Components/Cards/Cards';
import { CardDiteils } from './Components/CardsDeteil/CardsDeteils';

const App = () => {
  return (
    <Container className="font-dancing-script">
      <Row>
        <Route
          exact
          path="/"
          component={Cards}
        />
        <Route
          path="/diteils/:id"
          component={CardDiteils}
        />
      </Row>
    </Container>
  );
}

export default App;
