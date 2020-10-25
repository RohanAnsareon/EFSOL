import React, { useEffect, useState } from 'react'
import { getQuestions } from '../../services/questionary.service';

const QuestionaryComponent: React.FunctionComponent = () => {
    const [questions, setQuestions] = useState([]);
    
    useEffect(() => {
        const foo = async () => {
            let response = await getQuestions() 
            setQuestions(response.data);

            console.log(response);
        }

        foo();
    }, [])

    return (
        <h1>Questionary Works!</h1>
    );
}

export default QuestionaryComponent;