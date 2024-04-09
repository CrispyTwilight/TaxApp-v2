-- Auth: John O'Neal
-- Date: 04/08/2024
-- Desc: This SQL Server script creates the database schema and tables for the tax application.

-- Create users table. These are company employees.
CREATE TABLE users (
    user_id INT PRIMARY KEY IDENTITY(1,1),
    username VARCHAR(50) NOT NULL,
    password_hash VARCHAR(64) NOT NULL,
    role VARCHAR(18) NOT NULL
);

-- Create employees table. These are the users of the application.
CREATE TABLE employees (
    employee_id INT PRIMARY KEY IDENTITY(1,1),
    user_id INT UNIQUE,
    first_name VARCHAR(50) NOT NULL,
    middle_name VARCHAR(50),
    last_name VARCHAR(50) NOT NULL,
    address_line1 VARCHAR(100),
    address_line2 VARCHAR(100),
    city VARCHAR(50),
    state CHAR(2),
    zip CHAR(10),
    home_phone VARCHAR(15),
    mobile_phone VARCHAR(15),
    email VARCHAR(100),
    FOREIGN KEY (user_id) REFERENCES users(user_id)
);

-- Create clients table
CREATE TABLE clients (
    client_id INT PRIMARY KEY IDENTITY(1,1),
    first_name VARCHAR(50) NOT NULL,
    middle_name VARCHAR(50),
    last_name VARCHAR(50) NOT NULL,
    suffix VARCHAR(10),
    ssn CHAR(11) NOT NULL UNIQUE,
    birth_date DATE,
    home_phone VARCHAR(15),
    mobile_phone VARCHAR(15),
    email VARCHAR(100),
    address_line1 VARCHAR(100),
    address_line2 VARCHAR(100),
    city VARCHAR(50),
    state CHAR(2),
    zip CHAR(10),
    occupation VARCHAR(50),
    routing_number CHAR(9),
    account_number CHAR(17),
    checking BIT,
    savings BIT,
    user_id INT FOREIGN KEY REFERENCES users(user_id)
);

-- Create invoices table
CREATE TABLE invoices (
    invoice_id INT PRIMARY KEY IDENTITY(1,1),
    client_id INT,
    employee_id INT,
    invoice_date DATE,
    due_date DATE,
    amount DECIMAL(15, 2),
    paid BIT,
    payment_date DATE,
    FOREIGN KEY (client_id) REFERENCES clients(client_id),
    FOREIGN KEY (employee_id) REFERENCES employees(employee_id)
);

-- Create appointments table
CREATE TABLE appointments (
    appointment_id INT PRIMARY KEY IDENTITY(1,1),
    client_id INT,
    employee_id INT,
    date DATE,
    time TIME,
    purpose VARCHAR(255),
    FOREIGN KEY (client_id) REFERENCES clients(client_id),
    FOREIGN KEY (employee_id) REFERENCES employees(employee_id)
);

-- Create w2 table
CREATE TABLE w2 (
    w2_id INT PRIMARY KEY IDENTITY(1,1),
    client_id INT,
    tax_year INT,
    employer_ein CHAR(10),
    employer_name VARCHAR(255),
    employer_address_line1 VARCHAR(100),
    employer_address_line2 VARCHAR(100),
    employer_city VARCHAR(50),
    employer_state CHAR(2),
    employer_zip CHAR(10),
    control_number CHAR(10),
    wages DECIMAL(15, 2),
    federal_tax_withheld DECIMAL(15, 2),
    social_security_wages DECIMAL(15, 2),
    social_security_tax_withheld DECIMAL(15, 2),
    medicare_wages_and_tips DECIMAL(15, 2),
    medicare_tax_withheld DECIMAL(15, 2),
    social_security_tips DECIMAL(15, 2),
    allocated_tips DECIMAL(15, 2),
    dependent_care_benefits DECIMAL(15, 2),
    non_qualified_plans DECIMAL(15, 2),
    statutory_employee BIT,
    retirement_plan BIT,
    third_party_sick_pay BIT,
    box_12a_code CHAR(1),
    box_12a_amount DECIMAL(15, 2),
    box_12b_code CHAR(1),
    box_12b_amount DECIMAL(15, 2),
    box_12c_code CHAR(1),
    box_12c_amount DECIMAL(15, 2),
    box_12d_code CHAR(1),
    box_12d_amount DECIMAL(15, 2),
    other VARCHAR(255),
    state CHAR(2),
    state_employer_id CHAR(10),
    state_wages DECIMAL(15, 2),
    state_tax_withheld DECIMAL(15, 2),
    local_wages DECIMAL(15, 2),
    local_tax_withheld DECIMAL(15, 2),
    local_name VARCHAR(255),
    FOREIGN KEY (client_id) REFERENCES clients(client_id)
);

-- Create schedule_d_metadata table. This info comes above part 1 of the Schedule D form.
CREATE TABLE schedule_d_metadata (
    schedule_d_metadata_id INT PRIMARY KEY IDENTITY(1,1),
    client_id INT,
    tax_year INT,
    yes_disposal_of_opportunity_fund BIT,
    no_disposal_of_opportunity_fund BIT,
    FOREIGN KEY (client_id) REFERENCES clients(client_id)
);

-- Create schedule_d_short_term table. This is part 1 of the Schedule D form.
CREATE TABLE schedule_d_short_term (
    schedule_d_short_term_id INT PRIMARY KEY IDENTITY(1,1),
    schedule_d_metadata_id INT,
    form1099b_proceeds DECIMAL(15, 2),
    form1099b_cost DECIMAL(15, 2),
    form1099b_adjustment DECIMAL(15, 2),
    form1099b_gain_loss DECIMAL(15, 2),
    form8949_box_a_proceeds DECIMAL(15, 2),
    form8949_box_a_cost DECIMAL(15, 2),
    form8949_box_a_adjustment DECIMAL(15, 2),
    form8949_box_a_gain_loss DECIMAL(15, 2),
    form8949_box_b_proceeds DECIMAL(15, 2),
    form8949_box_b_cost DECIMAL(15, 2),
    form8949_box_b_adjustment DECIMAL(15, 2),
    form8949_box_b_gain_loss DECIMAL(15, 2),
    form8949_box_c_proceeds DECIMAL(15, 2),
    form8949_box_c_cost DECIMAL(15, 2),
    form8949_box_c_adjustment DECIMAL(15, 2),
    form8949_box_c_gain_loss DECIMAL(15, 2),
    gain_loss_forms6252_4684_6781_8824 DECIMAL(15, 2),
    net_gain_loss_schedule_k1 DECIMAL(15, 2),
    capital_loss_carryover DECIMAL(15, 2),
    net_short_term_capital_gain_loss DECIMAL(15, 2),
    FOREIGN KEY (schedule_d_metadata_id) REFERENCES schedule_d_metadata(schedule_d_metadata_id)
);

-- Create schedule_d_long_term table. This is part 2 of the Schedule D form.
CREATE TABLE schedule_d_long_term (
    schedule_d_long_term_id INT PRIMARY KEY IDENTITY(1,1),
    schedule_d_metadata_id INT,
    form1099b_proceeds DECIMAL(15, 2),
    form1099b_cost DECIMAL(15, 2),
    form1099b_adjustment DECIMAL(15, 2),
    form1099b_gain_loss DECIMAL(15, 2),
    form8949_box_d_proceeds DECIMAL(15, 2),
    form8949_box_d_cost DECIMAL(15, 2),
    form8949_box_d_adjustment DECIMAL(15, 2),
    form8949_box_d_gain_loss DECIMAL(15, 2),
    form8949_box_e_proceeds DECIMAL(15, 2),
    form8949_box_e_cost DECIMAL(15, 2),
    form8949_box_e_adjustment DECIMAL(15, 2),
    form8949_box_e_gain_loss DECIMAL(15, 2),
    form8949_box_f_proceeds DECIMAL(15, 2),
    form8949_box_f_cost DECIMAL(15, 2),
    form8949_box_f_adjustment DECIMAL(15, 2),
    form8949_box_f_gain_loss DECIMAL(15, 2),
    gain_loss_forms4797_2439_6252_4684_6781_8824 DECIMAL(15, 2),
    net_gain_loss_schedule_k1 DECIMAL(15, 2),
    capital_gain_distributions DECIMAL(15, 2),
    capital_loss_carryover DECIMAL(15, 2),
    net_long_term_capital_gain_loss DECIMAL(15, 2),
    FOREIGN KEY (schedule_d_metadata_id) REFERENCES schedule_d_metadata(schedule_d_metadata_id)
);

-- Create schedule_d_summary table. This is part 3 of the Schedule D form.
CREATE TABLE schedule_d_summary (
    schedule_d_summary_id INT PRIMARY KEY IDENTITY(1,1),
    schedule_d_metadata_id INT,
    total_gain_loss DECIMAL(15, 2),
    yes_line15_16_both_gains BIT,
    no_line15_16_both_gains BIT,
    rate_gain_28_line7 DECIMAL(15, 2),
    unrecaptured_section1250_gain_line18 DECIMAL(15, 2),
    yes_line18_19_zero_and_not_filing_form4952 BIT,
    no_line18_19_zero_and_not_filing_form4952 BIT,
    line16_loss DECIMAL(15, 2),
    yes_qualified_dividends_line3a BIT,
    no_qualified_dividends_line3a BIT,
    FOREIGN KEY (schedule_d_metadata_id) REFERENCES schedule_d_metadata(schedule_d_metadata_id)
);

-- Create form1098e table
CREATE TABLE form1098e (
    form1098e_id INT PRIMARY KEY IDENTITY(1,1),
    client_id INT,
    tax_year INT,
    corrected BIT,
    recipient_name VARCHAR(255),
    recipient_address_line1 VARCHAR(100),
    recipient_address_line2 VARCHAR(100),
    recipient_city VARCHAR(50),
    recipient_state CHAR(2),
    recipient_zip CHAR(10),
    recipient_phone VARCHAR(15),
    recipient_tin CHAR(10),
    borrower_tin CHAR(10),
    account_number CHAR(17),
    student_loan_interest_received_by_lender DECIMAL(15, 2),
    box2 BIT,
    FOREIGN KEY (client_id) REFERENCES clients(client_id)
);

-- Create schedule_k1 table
CREATE TABLE schedule_k1 (
    schedule_k1_id INT PRIMARY KEY IDENTITY(1,1),
    client_id INT,
    tax_year INT,
    final_k1 BIT,
    amended_k1 BIT,
    beginning_date DATE,
    ending_date DATE,
    estate_or_trust_ein CHAR(10),
    estate_or_trust_name VARCHAR(255),
    fiduciary_name VARCHAR(255),
    fiduciary_address_line1 VARCHAR(100),
    fiduciary_address_line2 VARCHAR(100),
    fiduciary_city VARCHAR(50),
    fiduciary_state CHAR(2),
    fiduciary_zip CHAR(10),
    d_1041t_filed BIT,
    d_date_filed DATE,
    e_final_form1041 BIT,
    beneficiary_id CHAR(11),
    beneficiary_name VARCHAR(255),
    beneficiary_street_address VARCHAR(100),
    beneficiary_city VARCHAR(50),
    beneficiary_state CHAR(2),
    beneficiary_zip CHAR(10),
    h_domestic_beneficiary BIT,
    h_foreign_beneficiary BIT,
    interest_income DECIMAL(15, 2),
    ordinary_dividends DECIMAL(15, 2),
    qualified_dividends DECIMAL(15, 2),
    net_short_term_capital_gain DECIMAL(15, 2),
    net_long_term_capital_gain DECIMAL(15, 2),
    rate_28_gain DECIMAL(15, 2),
    other_portfolio_and_non_business_income DECIMAL(15, 2),
    ordinary_business_income DECIMAL(15, 2),
    net_rental_real_estate_income DECIMAL(15, 2),
    other_rental_income DECIMAL(15, 2),
    directly_apportioned_deductions DECIMAL(15, 2),
    estate_tax_deduction DECIMAL(15, 2),
    final_year_deductions DECIMAL(15, 2),
    alternative_minimum_tax_adjustment DECIMAL(15, 2),
    credits_credit_recapture DECIMAL(15, 2),
    other_information VARCHAR(255),
    FOREIGN KEY (client_id) REFERENCES clients(client_id)
);

-- Create form1040 table
CREATE TABLE form1040 (
    form1040_id INT PRIMARY KEY IDENTITY(1,1),
    client_id INT,
    beginning_month_day VARCHAR(12),
    ending_month_day VARCHAR(12),
    ending_year_last_2_digits CHAR(2),
    address_line1 VARCHAR(100),
    address_line2 VARCHAR(100),
    city VARCHAR(50),
    state CHAR(2),
    zip CHAR(10),
    foreign_country_name VARCHAR(50),
    foreign_province_state_county VARCHAR(50),
    foreign_postal_code VARCHAR(10),
    you_presidential_election_fund BIT,
    spouse_presidential_election_fund BIT,
    -- Filings status section
    single BIT,
    married_filing_jointly BIT,
    married_filing_separately BIT,
    head_of_household BIT,
    qualifying_surviving_spouse BIT,
    filing_status_name VARCHAR(50),
    -- Digital asset transaction section
    yes_digital_asset_transaction BIT,
    no_digital_asset_transaction BIT,
    -- Standard deduction section
    you_as_a_dependent BIT,
    spouse_as_a_dependent BIT,
    spouse_itemizes BIT,
    -- Age/Blindness section
    born_before_jan2_1959 BIT,
    blind BIT,
    spouse_born_before_jan2_1959 BIT,
    spouse_blind BIT,
    -- Dependents section
    more_than_4_dependents BIT,
    FOREIGN KEY (client_id) REFERENCES clients(client_id)
);

-- Create form1040_dependents table
CREATE TABLE form1040_dependents (
    form1040_dependents_id INT PRIMARY KEY IDENTITY(1,1),
    form1040_id INT UNIQUE,
    -- Dependents section
    first_name VARCHAR(50) NOT NULL,
    last_name VARCHAR(50) NOT NULL,
    ssn CHAR(11) NOT NULL UNIQUE,
    relationship VARCHAR(50),
    child_tax_credit BIT,
    credit_for_other_dependents BIT,
    FOREIGN KEY (form1040_id) REFERENCES form1040(form1040_id)
);

-- Create form1040_income table
CREATE TABLE form1040_income (
    form1040_income_id INT PRIMARY KEY IDENTITY(1,1),
    form1040_id INT UNIQUE,
    -- Income section
    total_w2_income DECIMAL(15, 2), -- Line 1a: Total amount from Form(s) W-2, box 1
    household_employee_wages DECIMAL(15, 2), -- Line 1b: Household employee wages not reported on Form(s) W-2
    tip_income DECIMAL(15, 2), -- Line 1c: Tip income not reported on line 1a
    medicaid_waiver_payments DECIMAL(15, 2), -- Line 1d: Medicaid waiver payments not reported on Form(s) W-2
    dependent_care_benefits DECIMAL(15, 2), -- Line 1e: Taxable dependent care benefits from Form 2441, line 26
    adoption_benefits DECIMAL(15, 2), -- Line 1f: Employer-provided adoption benefits from Form 8839, line 29
    form8919_wages DECIMAL(15, 2), -- Line 1g: Wages from Form 8919, line 6
    other_earned_income DECIMAL(15, 2), -- Line 1h: Other earned income
    combat_pay_election DECIMAL(15, 2), -- Line 1i: Nontaxable combat pay election
    total_earned_income DECIMAL(15, 2), -- Line 1z: Add lines 1a through 1h
    tax_exempt_interest DECIMAL(15, 2), -- Line 2a: Tax-exempt interest
    taxable_interest DECIMAL(15, 2), -- Line 2b: Taxable interest
    qualified_dividends DECIMAL(15, 2), -- Line 3a: Qualified dividends
    ordinary_dividends DECIMAL(15, 2), -- Line 3b: Ordinary dividends
    ira_distributions DECIMAL(15, 2), -- Line 4a: IRA distributions
    taxable_ira_distributions DECIMAL(15, 2), -- Line 4b: Taxable amount of IRA distributions
    pensions_annuities DECIMAL(15, 2), -- Line 5a: Pensions and annuities
    taxable_pensions_annuities DECIMAL(15, 2), -- Line 5b: Taxable amount of pensions and annuities
    social_security_benefits DECIMAL(15, 2), -- Line 6a: Social security benefits
    taxable_social_security_benefits DECIMAL(15, 2), -- Line 6b: Taxable amount of social security benefits
    lump_sum_election BIT, -- Lump-sum election method (checkbox for line 6c)
    schedule_d_not_required BIT, -- Schedule D required (checkbox for line 7)
    capital_gain_loss DECIMAL(15, 2), -- Line 7: Capital gain or (loss)
    additional_income DECIMAL(15, 2), -- Line 8: Additional income from Schedule 1, line 10
    total_income DECIMAL(15, 2), -- Line 9: Total income (sum of various lines)
    adjustments_to_income DECIMAL(15, 2), -- Line 10: Adjustments to income from Schedule 1, line 26
    adjusted_gross_income DECIMAL(15, 2), -- Line 11: Adjusted gross income (total income minus adjustments)
    standard_or_itemized_deduction DECIMAL(15, 2), -- Line 12: Standard deduction or itemized deductions
    qualified_business_income_deduction DECIMAL(15, 2), -- Line 13: Qualified business income deduction
    taxable_income DECIMAL(15, 2), -- Line 15: Taxable income (adjusted gross income minus deductions)
    FOREIGN KEY (form1040_id) REFERENCES form1040(form1040_id)
);

-- Create form1040_tax_payments table
CREATE TABLE form1040_tax_payments (
    form1040_tax_payments_id INT PRIMARY KEY IDENTITY(1,1),
    form1040_id INT UNIQUE,
    -- Tax and credits section
    tax DECIMAL(15, 2), -- Line 16: Tax
    box1_8814 BIT, -- Line 16 Box 1: Tax from form 8814 attached
    box2_4972 BIT, -- Line 16 Box 2: Tax from form 4972 attached
    box3_ BIT, -- Line 16 Box 3: Tax from other forms attached
    box3_form_number VARCHAR(4), -- Line 16 Box 3: Form number
    schedule2_amount DECIMAL(15, 2), -- Line 17: Amount from Schedule 2, line 3
    line18_total DECIMAL(15, 2), -- Line 18: Total tax (sum of lines 16 and 17)
    child_tax_credit DECIMAL(15, 2), -- Line 19: Child tax credit or credit for other dependents from Schedule 8812
    schedule3_amount DECIMAL(15, 2), -- Line 20: Amount from Schedule 3, line 8
    line21_total DECIMAL(15, 2), -- Line 21: Total tax credits (sum of lines 19 and 20)
    line22_result DECIMAL(15, 2), -- Line 22: Subtract line 21 from line 18
    other_taxes DECIMAL(15, 2), -- Line 23: Other taxes, including self-employment tax, from Schedule 2, line 21
    total_tax DECIMAL(15, 2), -- Line 24: Total tax (sum of lines 22 and 23)
    -- Payments section
    form_w2_federal_income_tax_withheld DECIMAL(15, 2), -- Line 25a: Federal income tax withheld from Form(s) W-2
    form1099_federal_income_tax_withheld DECIMAL(15, 2), -- Line 25b: Federal income tax withheld from Form(s) 1099
    other_forms_federal_income_tax_withheld DECIMAL(15, 2), -- Line 25c: Federal income tax withheld from other forms
    total_federal_income_tax_withheld DECIMAL(15, 2), -- Line 25d: Federal income tax withheld (sum of lines 25a through 25c)
    estimated_tax_payments DECIMAL(15, 2), -- Line 26: Estimated tax payments and amount applied from prior return
    earned_income_credit DECIMAL(15, 2), -- Line 27: Earned income credit (EIC)
    additional_child_tax_credit DECIMAL(15, 2), -- Line 28: Additional child tax credit from Schedule 8812
    american_opportunity_credit DECIMAL(15, 2), -- Line 29: American opportunity credit from Form 8863, line 8
    schedule3_line15_amount DECIMAL(15, 2), -- Line 31: Amount from Schedule 3, line 15
    total_other_payments_refundable_credits DECIMAL(15, 2), -- Line 32: Total other payments and refundable credits (sum of lines 27, 28, 29, and 31)
    total_payments DECIMAL(15, 2), -- Line 33: Total payments (sum of lines 25d, 26, and 32)
    -- Refund section
    overpaid_amount DECIMAL(15, 2), -- Line 34: Amount overpaid (if line 33 is more than line 24)
    refund_request_amount DECIMAL(15, 2), -- Line 35a: Amount of line 34 to be refunded
    form8888_attached BIT, -- Line 35a: Form 8888 attached
    apply_to_estimated_tax DECIMAL(15, 2), -- Line 36: Amount of line 34 to be applied to next years estimated tax
    -- Amount you owe section
    amount_owe DECIMAL(15, 2), -- Line 37: Amount owed (if line 33 is less than line 24)
    estimated_tax_penalty DECIMAL(15, 2), -- Line 38: Estimated tax penalty
    -- Third party designee section
    yes_designee BIT,
    no_designee BIT,
    designee_name VARCHAR(50),
    designee_phone VARCHAR(15),
    designee_pin CHAR(5),
    -- Signature section
    signature VARBINARY(MAX),
    date DATE,
    occupation VARCHAR(50),
    identity_protection_pin CHAR(6),
    spouse_signature VARBINARY(MAX),
    spouse_date DATE,
    spouse_occupation VARCHAR(50),
    spouse_identity_protection_pin CHAR(6),
    phone VARCHAR(15),
    email VARCHAR(100),
    -- Paid preparer use only section
    preparer_name VARCHAR(50),
    preparer_firm_name VARCHAR(50),
    preparer_address_line1 VARCHAR(100),
    preparer_address_line2 VARCHAR(100),
    preparer_city VARCHAR(50),
    preparer_state CHAR(2),
    preparer_zip CHAR(10),
    preparer_ptin CHAR(9),
    preparer_phone VARCHAR(15),
    preparer_firm_ein CHAR(10),
    FOREIGN KEY (form1040_id) REFERENCES form1040(form1040_id)
);
