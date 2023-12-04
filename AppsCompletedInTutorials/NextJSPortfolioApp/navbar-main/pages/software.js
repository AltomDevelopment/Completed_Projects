
// use smaller components to add in to larger components, for example in Nav Bar (the page should be made up of these components)
function PageContainer() {
    return (
        <div></div>
    )
}

function ThreeJsContainer() {
    return (
        <div>
            <h2>Three JS Container</h2>
        </div>
    )
}

function SoftwareDevelopmentCycle() {
    return (
        <div>
        <h2>My Software Development Cycle</h2>
        <p>explanation text with images to go along with the text</p>
        </div>
    )
}


function ExampleProjects() {
    return (
        <div>
        <h2>Example Projects</h2>
        <p>Example Project 1 with gif image</p>
        <p>Example Project 2 with gif image</p>
        <p>Example Project 3 with gif image</p>
        </div>
    )
}


function ContactPage() {
    return (
        <h2>Click to go to contact Page</h2>
    )
}


export default function PageBanner() {
    return (
      <PageContainer>
        <ThreeJsContainer></ThreeJsContainer>
        <SoftwareDevelopmentCycle></SoftwareDevelopmentCycle>
        <ExampleProjects></ExampleProjects>
        <ContactPage></ContactPage>
      </PageContainer>
    )
  }